import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-add-lot",
  templateUrl: "./add-lot.component.html",
  styleUrls: ["./add-lot.component.css"]
})
export class AddLotComponent implements OnInit {
  imagePath: string = "../assets/upload-img-def.png";
  photoToUpload: File;

  constructor() {}

  ngOnInit() {}

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
