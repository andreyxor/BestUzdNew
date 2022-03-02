import { Component, OnInit } from '@angular/core';
import { clinics } from './controls/working-place/working-place.data';

@Component({
  selector: 'app-contacts-page',
  templateUrl: './contacts-page.component.html',
  styleUrls: ['./contacts-page.component.scss']
})
export class ContactsPageComponent implements OnInit {
  clc = clinics;

  constructor() { }

  ngOnInit(): void {
  }

}
