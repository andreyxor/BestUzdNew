import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ServiceListPageRoutingModule } from './service-list-page-routing.module';
import { ServiceListPageComponent } from './service-list-page.component';
import { ServiceItemComponent } from './components/service-item/service-item.component';
import { ChildServiceItemComponent } from './components/child-service-item/child-service-item.component';
import { ServiceListURLComponent } from './components/service-list-url/service-list-url.component';
import { ServiceItemDetailsComponent } from './components/service-item-details/service-item-details.component';


@NgModule({
  declarations: [ServiceListPageComponent, ServiceItemComponent, ChildServiceItemComponent, ServiceListURLComponent, ServiceItemDetailsComponent],
  imports: [
    CommonModule,
    ServiceListPageRoutingModule
  ]
})
export class ServiceListPageModule { }
