import { BaseModel } from './base-model';

export class BaseStatus extends BaseModel {
    public health: number;
    public firepower: number;
    public torpedo: number;
    public aviation: number;
    public anti_air: number;
    public reload: number;
    public evasion: number;
    public speed: number;
    public accuracy: number;
    public luck: number;
    public anti_submarine_warfare: number;
    public oil_consumption: number;
    public oxygen: number;
    public ammunition: number;
    public power: number;

    constructor() {
        super();

        this.health = 0;
        this.firepower = 0;
        this.torpedo = 0;
        this.aviation = 0;
        this.anti_air = 0;
        this.reload = 0;
        this.evasion = 0;
        this.speed = 0;
        this.accuracy = 0;
        this.luck = 0;
        this.anti_submarine_warfare = 0;
        this.oil_consumption = 0;
        this.oxygen = 0;
        this.ammunition = 0;
        this.power = 0;
    }
}
