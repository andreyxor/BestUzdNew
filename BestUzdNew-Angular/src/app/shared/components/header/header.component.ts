import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  public navBarElements = [
    {
      name: 'Головна',
      url: [''],
      active: false
    },
    {
      name: 'Послуги та цiни',
      url: ['/Послуги'],
      active: false
    },
    {
      name: 'Про клiніку',
      url: ['/Про-клініку'],
      active: false
    },
    {
      name: 'Контакти',
      url: ['/Контакти'],
      active: false
    }
  ]

  ngOnInit(): void {
  }
}
