import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { HabijabiComponent } from './habijabi.component';

describe('HabijabiComponent', () => {
  let component: HabijabiComponent;
  let fixture: ComponentFixture<HabijabiComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ HabijabiComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(HabijabiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
