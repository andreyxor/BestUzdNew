import { Component, Input, OnInit } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { WorkingPlaceDto } from './working-place.data';

@Component({
  selector: 'app-working-place',
  templateUrl: './working-place.component.html',
  styleUrls: ['./working-place.component.scss']
})
export class WorkingPlaceComponent implements OnInit {
  @Input()
  clinic: WorkingPlaceDto = null as any;
  
  constructor(protected _sanitizer: DomSanitizer) {
  }

  ngOnInit(): void {
  }

  sanitize(url: string) {
    return this._sanitizer.bypassSecurityTrustResourceUrl(url);
  }
}
