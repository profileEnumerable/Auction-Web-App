import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from "src/environments/environment";

@Injectable({
  providedIn: "root"
})
export class SignInService {
  constructor(private httpClient: HttpClient) {}

  userAuthentication(userName, password) {
    let userData = `username=${userName}&password=${password}&grant_type=password`;
    let requestHeader = new HttpHeaders({
      "Content-Type": "application/x-www-urlencoded"
    });

    let url: string = environment.localhost + environment.tokenPath;

    return this.httpClient.post(url, userData, { headers: requestHeader });
  }
}
