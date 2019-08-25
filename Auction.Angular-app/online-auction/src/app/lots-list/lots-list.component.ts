import { Component, OnInit } from "@angular/core";
import { Lot } from "../shered/models/lot.model";
import { LotsListService } from "../shered/services/lots-list.service";

@Component({
  selector: "app-lots-list",
  templateUrl: "./lots-list.component.html",
  styleUrls: ["./lots-list.component.css"]
})
export class LotsListComponent implements OnInit {
  lots: Lot[];
  startPageNum: number = 1;

  constructor(private lotsListService: LotsListService) {}

  ngOnInit() {
    this.lotsListService
      .getLotsByPageNumber(this.startPageNum)
      .subscribe(lotsArr => (this.lots = lotsArr), e => {});      
  }
}
