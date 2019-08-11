import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { AddLotComponent } from "./add-lot/add-lot.component";

const routes: Routes = [
  { path: "", pathMatch: "full", redirectTo: "addLot" },
  { path: "addLot", component: AddLotComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
