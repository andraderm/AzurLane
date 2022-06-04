import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Ship } from "../models/ship";

@Injectable({
    providedIn: 'root',
})
export class ShipService {
    private url: string = 'http://localhost:5053/ship';

    constructor(private httpClient: HttpClient) {
    }

    public getAll(): Observable<Ship[]> {
        return this.httpClient.get<Ship[]>(this.url);
    }
}
