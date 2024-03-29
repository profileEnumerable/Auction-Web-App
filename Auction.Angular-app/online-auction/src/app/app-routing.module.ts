import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AddLotComponent } from "./add-lot/add-lot.component";
import { LotsListComponent } from "./lots-list/lots-list.component";
import { SignInComponent } from "./sign-in/sign-in.component";
import { RegistrationComponent } from './registration/registration.component';

const routes: Routes = [
  { path: "", pathMatch: "full", redirectTo: "lotslist" },
  { path: "addLot", component: AddLotComponent },
  { path: "lotslist", component: LotsListComponent },
  { path: "sign-in", component: SignInComponent },
  { path: "registration", component: RegistrationComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
