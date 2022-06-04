import { Component, OnInit } from '@angular/core';
import { lastValueFrom } from 'rxjs';
import { Ship } from '../models/ship';
import { ShipService } from '../services/ship.service';

@Component({
    selector: 'app-ship',
    templateUrl: './ship.component.html',
    styleUrls: ['./ship.component.css'],
})
export class ShipComponent implements OnInit {
    public ships: Ship[];
    public shipsOnFleet: Ship[];

    constructor(protected shipService: ShipService) {
        this.ships = new Array<Ship>();
        this.shipsOnFleet = new Array<Ship>();
    }

    async ngOnInit(): Promise<void> {
        const result = (await lastValueFrom(
            this.shipService.getAll()
        )) as Array<Ship>;

        this.ships = result;
    }
}
