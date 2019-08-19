import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
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

     console.log(user);

    return this.httpClient.post(path, user);
  }
}
