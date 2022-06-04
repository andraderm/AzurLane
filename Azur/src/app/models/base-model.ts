export class BaseModel {
    public id: string;
    public created_at: Date;
    public updated_at: Date;
    public removed: boolean;

    constructor() {
        this.id = '';
        this.created_at = new Date();
        this.updated_at = new Date();
        this.removed = false;
    }
}