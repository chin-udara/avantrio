1. I would choose a clean architecture (one would call it a monolith) over microservices due to maintainability. 
An e-commerce platform might be adversely affected by the "eventual consistency" aspect of microservices.

2. I would opt for a SQL relational database approach in-order to maintain consistent and structured data. 
Although, in-order to maintain product catalogs, I could opt for a document base NOSQL database. 
However, since integrity and consistency of the data is critical, I would opt for a SQL database.

3. I would implement API base system where the front-end would be an SPA. The SPA would communicate with the backend via a RESTFul api.
Since scalability is an aspect that needs to be addressed from the get-go, an API based design would allow me to later open a portal for developers or third-parties so that they could contribute to enhance the functionality via plugins.
Further, developing for different platforms such as mobile or other smart devices would only require the development of module in the front-end while the back-end remains intact.

4. For front-end I would choose Vue due its increasingly high flexibility and ease of maintainability.
VueJs is increasingly becoming popular among the development communities and will make my app future proof.

I would choose Dotnet Core to develop the backend functionality. 
Dotnet core has become platform independent and offers more control over the operations and the deployability compared to more traditional methods such as JVM based languages.

5. In terms of deploying the app in the cloud, I am indifferent between the three most widely used cloud providers.
However, I would pick AWS due to its relatively easier learning curve and due to the flexibility it offers in-terms of the technologies we can use.
AWS also offers highly scalable and managed database hosting (RDS) which would allow us to host our database.

6. I would use an AWS load balancer to divide the traffic among a cluster of EC2 nodes. Further, the database would be hosted in the AWS RDS allowing seamless expansion.

