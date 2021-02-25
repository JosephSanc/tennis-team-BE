import { Injectable, Inject } from '@angular/core';
import { Player } from './player-interface';
import { HttpClient } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class PlayerService {

  constructor(private http: HttpClient) { }

  getPlayers() {
    return this.http.get<Player[]>('players');
  }

  getSpecificPlayer(playerId: number) {
    return this.http.get<Player>('players/' + playerId);
  }

  deleteSpecificPlayer(playerId: number) {
    return this.http.delete<boolean>('players/delete' + playerId);
  }

  updatePlayer(player: Player) {
    return this.http.put<Player>('players/' + player.playerId, player);
  }

}
