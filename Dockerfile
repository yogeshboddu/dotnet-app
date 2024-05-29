# Use a base image with known vulnerabilities
FROM ubuntu:18.04

# Install a vulnerable package
RUN apt-get update && \
    apt-get install -y vulnerable-package && \
    rm -rf /var/lib/apt/lists/*

# Expose a port that may lead to security issues
EXPOSE 12345

# Copy an insecure script into the image
COPY insecure-script.sh /usr/local/bin/

# Set permissions that could be exploited
RUN chmod 777 /usr/local/bin/insecure-script.sh

# Run the vulnerable script on startup
CMD ["insecure-script.sh"]
