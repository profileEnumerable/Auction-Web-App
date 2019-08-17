import { Component, OnInit } from "@angular/core";
import { NgForm } from "@angular/forms";
import { User } from "../shered/models/user.model";

@Component({
  selector: "app-registration",
  templateUrl: "./registration.component.html",
  styleUrls: ["./registration.component.css"]
})
export class RegistrationComponent implements OnInit {
  user: User;

  constructor() {}

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form) {
      form.reset();
    }
    //1-variant//try it
    // this.user = null;

    //2-variant
    this.user = {
      email: "",
      password: "",
      userName: ""
    };
  }
}
