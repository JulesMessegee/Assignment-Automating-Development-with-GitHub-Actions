# Assignment-Automating-Development-with-GitHub-Actions
Short CPT_S 322 assignment

Assignment: Automating Development with GitHub Actions
Due Nov 22 by 11:59pm Points 5 Submitting a file upload
Assignment: Automating Development with GitHub Actions
Objective:
This assignment focuses on automating common development workflows using GitHub Actions. You will:

Automate the assignment of issues to a team member.
Run automated test cases for code merged into the main branch.
(Optional for extra credit) Deploy a web application to Docker Hub.
Tasks:
Task 1: Automate Issue Assignment (2 Marks):
Create a GitHub Actions workflow to automatically assign any new issue created in your repository to a specific team member.
Use GitHub Actions to implement the workflow with appropriate triggers and actions
Hint

steps:
    - name: Assign Issue
      uses: actions-ecosystem/action-assign@v2
      with:
        github-token: ${{ secrets.GITHUB_TOKEN }}
        assignees: X # Replace X with the GitHub username of the team member

Task 2: Run Automated Test Cases (3 Marks):
Create a workflow to run test cases whenever a pull request is merged into the main branch.
Use a testing framework suitable for your project (e.g., PyTest, or JUnit).
The workflow should:
Check out the repository.
Set up the environment.
Install dependencies.
Execute the test cases.
Task 3 (Optional for Extra Credit): Docker Deployment (3 Extra Marks):
Build and deploy your web application (created in the Docker Lab, use the repo that we used in Docker Lab Manula for the WebApp ) to Docker Hub.
Create a workflow to:
Build a Docker image using a Dockerfile.
Log in to Docker Hub using secrets (DOCKER_USERNAME and DOCKER_PASSWORD).
Push the image to Docker Hub with a specific tag (e.g., latest).
Additional Instructions:
Prepare a Report:

Include a brief summary of your implementation for each task.
Add sample .yml workflow files for each task.
Include screenshots to demonstrate the successful execution of workflows.
Add a section describing the challenges faced and how they were resolved.
Share Your GitHub Repository Link:

Include a link to your repository containing:
All .yml files under .github/workflows/.
Any supporting files (e.g., requirements.txt, application source code, Dockerfile).
The repository should be public or shared with the instructor.
Submission Requirements:

Submit the report in PDF format along with the GitHub repository link.
Ensure the repository structure is organized and workflows are properly commented.
Example Report Format:
Title: Assignment Report: Automating Development with GitHub Actions
Introduction:

Brief explanation of GitHub Actions and its use in CI/CD.
Task 1: Automate Issue Assignment:

Summary of implementation.
.yml file content.
Screenshot of workflow execution.
Task 2: Run Automated Test Cases:

Summary of implementation.
.yml file content.
Screenshot of workflow execution.
Task 3 (Optional): Docker Deployment:

Summary of implementation.
.yml file content.
Screenshot of Docker Hub repository with pushed image.
Challenges and Solutions:

Outline any difficulties faced during the tasks and how you overcame them.
GitHub Repository Link:

Provide the URL of your repository.
