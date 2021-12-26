import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChildServiceItemComponent } from './child-service-item.component';

describe('ChildServiceItemComponent', () => {
  let component: ChildServiceItemComponent;
  let fixture: ComponentFixture<ChildServiceItemComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChildServiceItemComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChildServiceItemComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
