import { Injectable } from "@angular/core";
import {
  HttpInterceptor,
  HttpRequest,
  HttpHandler,
  HttpEvent
} from "@angular/common/http";
import { Observable } from "rxjs";
import { Router } from "@angular/router";
import { tap } from "rxjs/operators";

@Injectable()
export class SignInInterceptor implements HttpInterceptor {
  constructor(private router: Router) {}

  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    if (req.headers.get("No-Auth") == "true") {
      return next.handle(req.clone());
    }

    let accessToken = localStorage.getItem("accessToken");

    if (accessToken) {
      let clonedReq = req.clone({
        headers: req.headers.set("Authorization", `Bearer ${accessToken}`)
      });

      return next.handle(clonedReq).pipe(
        tap(
          succ => {},
          error => {
            if (error.status == 401) {
              this.router.navigateByUrl("/sign-in");
            }
          }
        )
      );
    }
  }
}
