import { Component, OnInit } from "@angular/core";
import { AddLotService } from "../shered/services/add-lot.service";

@Component({
  selector: "app-add-lot",
  templateUrl: "./add-lot.component.html",
  styleUrls: ["./add-lot.component.css"]
})
export class AddLotComponent implements OnInit {
  imagePath: string = "../assets/upload-img-def.png";
  photoToUpload: File;
  lifetimeMap: Map<string, Date>;
  lifetimeDates: any; //itarable obj with Map keys that represent dates like str
  banks: string[];

  constructor(private addLotService: AddLotService) {}

  ngOnInit() {
    this.lifetimeMap = this.addLotService.getlifetimeDates();
    this.lifetimeDates = this.lifetimeMap.keys();
    this.banks = this.addLotService.banks;
  }

  //changeing the preview photo
  lotPhotoChanged(photoFiles: FileList) {
    this.photoToUpload = photoFiles.item(0);

    const reader = new FileReader();

    reader.onload = (event: any) => {
      console.log(event.target);
      this.imagePath = event.target.result;
    };

    reader.readAsDataURL(this.photoToUpload);
  }
}
