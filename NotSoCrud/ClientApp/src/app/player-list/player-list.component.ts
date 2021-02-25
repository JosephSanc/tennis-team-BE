import { JsonPipe } from '@angular/common';
import { Component, OnInit, OnChanges } from '@angular/core';
import { Player } from '../models/player-interface';
import { PlayerService } from '../models/player-service.service';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-player-list',
  templateUrl: './player-list.component.html',
  styleUrls: ['./player-list.component.css']
})
export class PlayerListComponent implements OnInit {
  private players: Player[];

  constructor(private playerService: PlayerService) {
    playerService.getPlayers().subscribe(result => {
        this.players = result;
      },
      error => console.error(error));
  }

  ngOnInit(): void {
  }

  ngOnChanges(){

  }

  deletePlayer(playerId: number) {
    this.playerService.deleteSpecificPlayer(playerId);
  }

}
