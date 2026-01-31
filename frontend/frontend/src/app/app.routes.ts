import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    redirectTo: 'episodes',
    pathMatch: 'full'
  },
  {
    path: 'episodes',
    loadComponent: () =>
      import('./components/episodes/episodes.component')
        .then(m => m.EpisodesComponent)
  }
];
