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
    let url: string = environment.localhost + environment.userRegistration;

    let reqHeader = new HttpHeaders({ "No-Auth": "true" });
    return this.httpClient.post(url, user, { headers: reqHeader });
  }

  getUserClaims() {
    let url: string = environment.localhost + environment.getUserClaims;

    return this.httpClient.get(url);
  }
}
