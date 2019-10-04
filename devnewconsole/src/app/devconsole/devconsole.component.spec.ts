import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DevconsoleComponent } from './devconsole.component';

describe('DevconsoleComponent', () => {
  let component: DevconsoleComponent;
  let fixture: ComponentFixture<DevconsoleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DevconsoleComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DevconsoleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
