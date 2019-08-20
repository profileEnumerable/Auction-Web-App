import { Component, OnInit } from "@angular/core";
import { NgForm } from "@angular/forms";
import { User } from "../shered/models/user.model";
import { RegisterService } from "../shered/services/register.service";

@Component({
  selector: "app-registration",
  templateUrl: "./registration.component.html",
  styleUrls: ["./registration.component.css"]
})
export class RegistrationComponent implements OnInit {
  user: User;

  constructor(private registrationService: RegisterService) {}

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

  onSubmit(form: NgForm) {
    this.registrationService.registerUser(form.value).subscribe((data: any) => {
      if (data.Succeeded) {
        console.log("Succeeded");
        this.resetForm(form);
      } else {
        console.error("error");
      }
    });
  }
}
