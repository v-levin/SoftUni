const mongoose = require('mongoose');
const Article = mongoose.model('Article');

module.exports = {
  index: (req, res) => {
      Article.find({}).limit(6).populate('author').then(articles => {
          for (let article of articles) {
              if (article.content.length > 400) {
                  article.content = article.content.substr(0, 400) + '...';
              }
          }

          res.render('home/index', {articles: articles});
      })
  }
};