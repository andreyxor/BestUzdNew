import { Component, HostListener, Input, OnInit, ViewChild } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

@Component({
  selector: 'app-mobile-menu',
  templateUrl: './mobile-menu.component.html',
  styleUrls: ['./mobile-menu.component.scss']
})
export class MobileMenuComponent implements OnInit {
  public menuIsOpened = false;

  @ViewChild("insideElement", { static: false }) insideElement: any;
  @ViewChild("menuButton", { static: false }) menuButton: any;

  @HostListener('document:click', ['$event.target'])
  public onClick(targetElement: any) {
    const clikedMenu = this.menuButton.nativeElement.contains(targetElement);
    if (clikedMenu) {
      this.menuIsOpened = !this.menuIsOpened;
      return;
    }
    
    const clickedInside = this.insideElement.nativeElement.contains(targetElement);
    if (!clickedInside) {
      this.menuIsOpened = false;
    }
  }

  @Input()
  public navBarElements: any[] = [];

  constructor(public router: Router) {
    router.events.subscribe(event => {
      if (event instanceof NavigationEnd) {
        const currentUrls: string[] = event.url.split('/').map(x => decodeURI(x));
        currentUrls.shift(); // remove first one
        const firstUrlPart = currentUrls[0];
        this.navBarElements.forEach(x => x.active = false);
        const parentUrl = this.navBarElements.find(x => x.url[0].replace('/', '') === firstUrlPart);
        if (parentUrl) {
          parentUrl.active = true;
        }
      }
    })
  }

  ngOnInit(): void {
  }

  public openMenu() {
    this.menuIsOpened = !this.menuIsOpened;
  }
}
