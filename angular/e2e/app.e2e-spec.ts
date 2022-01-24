import { ClubTestTemplatePage } from './app.po';

describe('ClubTest App', function() {
  let page: ClubTestTemplatePage;

  beforeEach(() => {
    page = new ClubTestTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
