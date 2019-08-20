import { Component, OnInit } from "@angular/core";
import { NgForm } from "@angular/forms";
import { SignInService } from "../shered/services/sign-in.service";
import { HttpErrorResponse } from "@angular/common/http";
import { Router } from "@angular/router";

@Component({
  selector: "app-sign-in",
  templateUrl: "./sign-in.component.html",
  styleUrls: ["./sign-in.component.css"]
})
export class SignInComponent implements OnInit {
  constructor(private signInService: SignInService, private router: Router) {}

  isLoginError: boolean = false;
  ngOnInit() {}

  onSubmit(form) {
    const password = form.value.password;
    const userName = form.value.userName;

    this.signInService.userAuthentication(userName, password).subscribe(
      (data: any) => {
        localStorage.setItem("accessToken", data.access_token);

        this.router.navigate(["/lotslist"]);
      },
      (err: HttpErrorResponse) => {
        this.isLoginError = true;
      }
    );
  }
}
