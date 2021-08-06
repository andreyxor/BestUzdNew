import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ServiceListPageRoutingModule } from './service-list-page-routing.module';
import { ServiceListPageComponent } from './service-list-page.component';


@NgModule({
  declarations: [ServiceListPageComponent],
  imports: [
    CommonModule,
    ServiceListPageRoutingModule
  ]
})
export class ServiceListPageModule { }
