import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-add-lot",
  templateUrl: "./add-lot.component.html",
  styleUrls: ["./add-lot.component.css"]
})
export class AddLotComponent implements OnInit {
  imagePath: string = "../assets/upload-img-def.png";
  constructor() {}

  ngOnInit() {
    
  }
}
