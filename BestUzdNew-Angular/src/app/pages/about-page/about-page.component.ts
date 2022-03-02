import { Component, OnInit } from '@angular/core';
import { doctors } from './about-page.data';

@Component({
  selector: 'app-about-page',
  templateUrl: './about-page.component.html',
  styleUrls: ['./about-page.component.scss']
})
export class AboutPageComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  doctors = doctors;
}
