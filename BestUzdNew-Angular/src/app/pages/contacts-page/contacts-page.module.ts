import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ContactsPageRoutingModule } from './contacts-page-routing.module';
import { ContactsPageComponent } from './contacts-page.component';
import { WorkingPlaceComponent } from './controls/working-place/working-place.component';

@NgModule({
  declarations: [ContactsPageComponent, WorkingPlaceComponent],
  imports: [
    CommonModule,
    ContactsPageRoutingModule,
  ]
})
export class ContactsPageModule { }
