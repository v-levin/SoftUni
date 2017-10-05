package softuniBlog.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import softuniBlog.entity.Article;

import javax.persistence.criteria.CriteriaBuilder;

public interface ArticleRepository extends JpaRepository<Article, Integer> {
}
