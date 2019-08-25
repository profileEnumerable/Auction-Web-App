import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { FormsModule } from "@angular/forms";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { AddLotComponent } from "./add-lot/add-lot.component";
import { AddLotService } from "./shered/services/add-lot.service";
import { LotsListComponent } from "./lots-list/lots-list.component";
import { SignInComponent } from "./sign-in/sign-in.component";
import { LotsListService } from "./shered/services/lots-list.service";
import { RegistrationComponent } from "./registration/registration.component";
import { RegisterService } from "./shered/services/register.service";
import { SignInService } from "./shered/services/sign-in.service";
import { SignInInterceptor } from "./sign-in/sign-in.interceptor";

@NgModule({
  declarations: [
    AppComponent,
    AddLotComponent,
    LotsListComponent,
    SignInComponent,
    RegistrationComponent
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule, FormsModule],
  providers: [
    LotsListService,
    RegisterService,
    AddLotService,
    SignInService,
    {
      provide: HTTP_INTERCEPTORS,
      useClass: SignInInterceptor,
      multi: true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}
