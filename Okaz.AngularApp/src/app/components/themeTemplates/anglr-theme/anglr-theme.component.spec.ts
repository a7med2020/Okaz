import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AnglrThemeComponent } from './anglr-theme.component';

describe('AnglrThemeComponent', () => {
  let component: AnglrThemeComponent;
  let fixture: ComponentFixture<AnglrThemeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AnglrThemeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AnglrThemeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
