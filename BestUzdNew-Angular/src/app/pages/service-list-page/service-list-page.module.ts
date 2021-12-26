import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ServiceListPageRoutingModule } from './service-list-page-routing.module';
import { ServiceListPageComponent } from './service-list-page.component';
import { ServiceItemComponent } from './components/service-item/service-item.component';
import { ChildServiceItemComponent } from './components/child-service-item/child-service-item.component';


@NgModule({
  declarations: [ServiceListPageComponent, ServiceItemComponent, ChildServiceItemComponent],
  imports: [
    CommonModule,
    ServiceListPageRoutingModule
  ]
})
export class ServiceListPageModule { }
