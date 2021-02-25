import { Component, OnInit, OnChanges } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { Player } from '../models/player-interface';
import { PlayerService } from '../models/player-service.service';

@Component({
  selector: 'app-player-details',
  templateUrl: './player-details.component.html',
  styleUrls: ['./player-details.component.css']
})
export class PlayerDetailsComponent implements OnInit {

  constructor(private playerService: PlayerService, private route: ActivatedRoute) {} 

  players: Player[];

  editingPlayer: Player;
  playerId: number;
    
  ngOnInit() {
    this.playerId = +this.route.snapshot.paramMap.get('playerId');
    if (this.playerId) {
      this.playerService.getSpecificPlayer(this.playerId).subscribe(result => {
        this.editingPlayer = result;
      }, error => console.error());
    }
  }

  savePlayer() {
    this.playerService.updatePlayer(this.editingPlayer).subscribe(result => {
      console.log(result);
    });
  }


}
