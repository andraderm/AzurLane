import { Byte } from '@angular/compiler/src/util';
import { ArmorType } from '../enums/armor-type.enum';
import { Classification } from '../enums/classification.enum';
import { Rarity } from '../enums/rarity.enum';
import { ShipCombatPosition } from '../enums/ship-combat-position';
import { BaseStatus } from './base-status';

export class Ship extends BaseStatus {
    public name: string;
    public illustrator: string;
    public voice_actor: string;
    public faction: string;
    public ship_class: string;
    public image: Byte[];
    public flagship: boolean;
    public construction_time: Date;
    public armor_type: ArmorType;
    public rarity: Rarity;
    public ship_type: Classification;
    public combat_position: ShipCombatPosition;

    constructor() {
        super();

        this.name = '';
        this.illustrator = '';
        this.voice_actor = '';
        this.faction = '';
        this.ship_class = '';
        this.image = new Array<Byte>();
        this.flagship = false;
        this.construction_time = new Date();
        this.armor_type = ArmorType.Light;
        this.rarity = Rarity.Unknown;
        this.ship_type = Classification.Unknown;
        this.combat_position = ShipCombatPosition.Vanguard;
    }
}
