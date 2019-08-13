import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { AddLotComponent } from "./add-lot/add-lot.component";
import { AddLotService } from "./shered/add-lot.service";

@NgModule({
  declarations: [AppComponent, AddLotComponent],
  imports: [BrowserModule, AppRoutingModule],
  providers: [AddLotService],
  bootstrap: [AppComponent]
})
export class AppModule {}
