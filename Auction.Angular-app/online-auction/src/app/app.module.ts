import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { FormsModule } from "@angular/forms";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { AddLotComponent } from "./add-lot/add-lot.component";
import { AddLotService } from "./shered/services/add-lot.service";
import { LotsListComponent } from "./lots-list/lots-list.component";
import { SignInComponent } from "./user/sign-in/sign-in.component";
import { LotsListService } from "./shered/services/lots-list.service";
import { RegistrationComponent } from "./registration/registration.component";
import { UserComponent } from './user/user.component';
import { RegisterService } from './shered/services/register.service';

@NgModule({
  declarations: [
    AppComponent,
    AddLotComponent,
    LotsListComponent,
    SignInComponent,
    RegistrationComponent,
    UserComponent
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule, FormsModule],
  providers: [AddLotService, LotsListService,RegisterService],
  bootstrap: [AppComponent]
})
export class AppModule {}
