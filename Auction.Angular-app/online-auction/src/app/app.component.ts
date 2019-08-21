import { Component } from "@angular/core";
import { RegisterService } from "./shered/services/register.service";
import { Router } from "@angular/router";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.css"]
})
export class AppComponent {
  constructor(
    private registerService: RegisterService,
    private router: Router
  ) {}
  userClaims: any;

  logoutHandler() {
    localStorage.removeItem("accessToken");
    this.router.navigate(["/sign-in"]);

    this.userClaims = null;
  }

  routerOutletChanged() {
    if (!this.userClaims && localStorage.getItem("accessToken")) {
      this.registerService.getUserClaims().subscribe((claims: any) => {
        this.userClaims = claims;
      });
    }
  }
}
