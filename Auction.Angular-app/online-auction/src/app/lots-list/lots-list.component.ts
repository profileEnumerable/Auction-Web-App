import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-lots-list",
  templateUrl: "./lots-list.component.html",
  styleUrls: ["./lots-list.component.css"]
})
export class LotsListComponent implements OnInit {
  lots: number[] = new Array(3);

  constructor() {}

  ngOnInit() {}
}
