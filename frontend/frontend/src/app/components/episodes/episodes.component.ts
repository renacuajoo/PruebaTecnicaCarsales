import { Component, OnInit, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EpisodesService } from '../../services/episodes/episodes.service';
import { Episode } from '../../models/episode.model';

@Component({
  selector: 'app-episodes',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './episodes.component.html',
  styleUrl: './episodes.component.scss'
})
export class EpisodesComponent implements OnInit {

  // Estado reactivo con Signals (Angular moderno)
  episodes = signal<Episode[]>([]);
  currentPage = signal<number>(1);
  totalPages = signal<number>(1);

  constructor(private episodesService: EpisodesService) {}

  ngOnInit(): void {
    this.loadEpisodes(1);
  }

  loadEpisodes(page: number): void {
    this.currentPage.set(page);

    this.episodesService.getEpisodes(page).subscribe({
      next: (response) => {
        this.episodes.set(response.results);
        this.totalPages.set(response.info.pages);
      },
      error: (err) => {
        console.error('Error cargando episodios:', err);
      }
    });
  }
}
