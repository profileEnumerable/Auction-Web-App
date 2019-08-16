import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { AddLotComponent } from "./add-lot/add-lot.component";
import { AddLotService } from "./shered/add-lot.service";
import { LotsListComponent } from "./lots-list/lots-list.component";
import { SignInComponent } from "./sign-in/sign-in.component";
import { LotsListService } from "./shered/lots-list.service";

@NgModule({
  declarations: [
    AppComponent,
    AddLotComponent,
    LotsListComponent,
    SignInComponent
  ],
  imports: [BrowserModule, AppRoutingModule, HttpClientModule],
  providers: [AddLotService, LotsListService],
  bootstrap: [AppComponent]
})
export class AppModule {}
