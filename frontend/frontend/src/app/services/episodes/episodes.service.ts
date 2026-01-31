import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { EpisodesResponse } from '../../models/paged.episodes.model';

@Injectable({
  providedIn: 'root'
})
export class EpisodesService {

  private readonly apiUrl = 'http://localhost:5039/api/episodes';

  constructor(private http: HttpClient) {}

  getEpisodes(page: number = 1): Observable<EpisodesResponse> {
    return this.http.get<EpisodesResponse>(`${this.apiUrl}?page=${page}`);
  }
}
