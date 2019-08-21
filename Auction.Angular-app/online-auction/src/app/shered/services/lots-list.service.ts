import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { map } from "rxjs/operators";
import { Lot } from "../models/lot.model";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root"
})
export class LotsListService {
  constructor(private httpClient: HttpClient) {}

  getLotsByPageNumber(pageNumber: number): Observable<Lot[]> {
    let url: string =
      environment.localhost + environment.lotsByPageNum + pageNumber;

    return this.httpClient.get(url).pipe(
      map((response: any[]) => {
        let lots: Lot[] = [];

        for (let i = 0; i < response.length; i++) {
          let newLot: Lot = new Lot();

          newLot.id = response[i].Id;
          newLot.name = response[i].Name;
          newLot.startPrice = response[i].StartPrice;
          newLot.currentPrice = response[i].CurrentPrice;
          newLot.description = response[i].Description;
          newLot.dateAdded = response[i].DateAdded;

          lots.push(newLot);
        }

        return lots;
      })
    );
  }
}
