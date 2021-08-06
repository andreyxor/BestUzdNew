import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ServiceListPageComponent } from './service-list-page.component';

const routes: Routes = [
  {
    path: '',
    component: ServiceListPageComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ServiceListPageRoutingModule { }
