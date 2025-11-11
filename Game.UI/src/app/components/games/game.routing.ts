import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GamesComponent } from './games.component';
import { GameDetailsComponents } from './game-details.components';

const routes: Routes = [
  { path: '', component: GamesComponent },
  { path: 'edit/:id', component: GameDetailsComponents }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GameRoutingModule {}
