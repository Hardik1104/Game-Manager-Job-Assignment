import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Game } from '../../models/game';
import { GameService } from '../../services/game.service';

@Component({
  selector: 'app-games.component',
  standalone: false,
  templateUrl: './games.component.html',
  styleUrl: './games.component.scss',
})
export class GamesComponent implements OnInit  {
  games: Game[] = [];

  constructor(private gameService: GameService, private router: Router) {}

  ngOnInit(): void {
    this.loadGames();
  }

  loadGames() {
    this.gameService.getAll().subscribe(data => {
      this.games = data}
      );
  }
  deleteGame(id: number) {
    if (confirm('Are you sure you want to delete this game?')) {
      this.gameService.delete(id).subscribe(() => this.loadGames());
    }
  }

  editGame(id: number) {
    this.router.navigate(['/games/edit', id]);
  }
}
