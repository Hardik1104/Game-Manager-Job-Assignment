import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: 'games', loadChildren: () => import('./components/games/game.module').then(m => m.GameModule) },
  { path: '', redirectTo: 'games', pathMatch: 'full' },
  { path: '**', redirectTo: 'games' } // optional fallback
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
