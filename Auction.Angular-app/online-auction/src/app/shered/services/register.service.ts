import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { User } from "../models/user.model";
import { environment } from "src/environments/environment";
import { Observable } from "rxjs";

@Injectable({
  providedIn: "root"
})
export class RegisterService {
  constructor(private httpClient: HttpClient) {}

  registerUser(user: User): Observable<any> {
    let path: string = environment.localhost + environment.userRegistration;

    return this.httpClient.post(path, user);
  }

  getUserClaims() {
    let url: string = environment.localhost + environment.getUserClaims;

    let bearerToken = localStorage.getItem("accessToken");//get Bearer token
    var header = new HttpHeaders({ Authorization: "Bearer " + bearerToken });

    return this.httpClient.get(url, { headers: header });
  }
}
