import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GameService } from '../../services/game.service';
import { Game } from '../../models/game'

@Component({
  selector: 'app-game-details.components',
  standalone: false,
  templateUrl: './game-details.components.html',
  styleUrl: './game-details.components.scss',
})
export class GameDetailsComponents  implements OnInit{
  form!: FormGroup;
  id: number = -1;

  constructor(
    private fb: FormBuilder,
    private gameService: GameService,
    private route: ActivatedRoute,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.form = this.fb.group({
      title: ['', [Validators.required, Validators.maxLength(256)]],
      description: ['', [Validators.required, Validators.maxLength(2000)]],
      genres: ['', Validators.required],
      tags: ['', Validators.required],
      rating: [0, [Validators.required, Validators.min(0), Validators.max(10)]],
      launchDate: ['', Validators.required]
    });

    this.id = Number(this.route.snapshot.paramMap.get('id'));
    if (this.id) {
      this.gameService.getById(this.id).subscribe(game => {
        game.launchDate = game.launchDate?.split('T')[0] 
        this.form.patchValue(game);
      });
    }
  }
  save() {
    const now = new Date().toISOString();
    const game: Game = {
      ...this.form.value,
      addedOn: now,
      modifiedOn: now
    };

    if (this.id && this.id>0) {
      this.gameService.update(this.id, game).subscribe(() => this.router.navigate(['/games/edit', this.id]));
    } else {
      this.gameService.create(game).subscribe((game:Game) => this.router.navigate(['/games/edit',game.id]));
    }
  }
  deleteGame(id: number) {
    if (confirm('Are you sure you want to delete this game?')) {
      this.gameService.delete(id).subscribe(() => this.router.navigate(['/games']));
    }
  }

  cancel() {
    this.router.navigate(['/games']);
  }

}
