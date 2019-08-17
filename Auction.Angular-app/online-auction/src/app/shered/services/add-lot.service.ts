import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root"
})
export class AddLotService {
  constructor() {}

  lotLifetime: number = 7; //measurement in days

  banks: string[] = ["PrivatBank", "Oschadbank", "Ukreximbank"];

  getlifetimeDates() {
    const lifetimeDates = new Map();

    for (let i = 1; i <= this.lotLifetime; i++) {
      let offsetDate = new Date();
      let offset: number = offsetDate.getDate() + i;

      offsetDate.setDate(offset);

      let month: string = offsetDate.toLocaleString("default", {
        month: "long"
      });

      lifetimeDates.set(
        `${i} days - ${offsetDate.getDate()} ${month}`,
        offsetDate
      );
    }

    return lifetimeDates;
  }
}
