import { Component, OnInit } from '@angular/core';

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
      url: ['/сервисы'],
      active: false
    },
    {
      name: 'Про клiнику',
      url: ['/про-клинику'],
      active: false
    },
    {
      name: 'Контакти',
      url: ['/контакты'],
      active: false
    }
  ]
  constructor() { }

  ngOnInit(): void {
  }

  activate(navElement: any) {
    this.navBarElements.forEach(x => x.active = false);
    navElement.active = true;
  }
}
