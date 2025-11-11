import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { GamesComponent } from './games.component';
import { GameDetailsComponents } from './game-details.components';
import { GameRoutingModule } from './game.routing';



@NgModule({
  declarations: [
    GamesComponent,
    GameDetailsComponents
  ],
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    GameRoutingModule
  ]
})
export class GameModule { }
