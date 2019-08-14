import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { AddLotComponent } from "./add-lot/add-lot.component";
import { AddLotService } from "./shered/add-lot.service";
import { LotsListComponent } from './lots-list/lots-list.component';
import { SignInComponent } from './sign-in/sign-in.component';

@NgModule({
  declarations: [AppComponent, AddLotComponent, LotsListComponent, SignInComponent],
  imports: [BrowserModule, AppRoutingModule],
  providers: [AddLotService],
  bootstrap: [AppComponent]
})
export class AppModule {}
