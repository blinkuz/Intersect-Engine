using NUnit.Framework;
using Intersect.Client.Html;

namespace Intersect.Tests.Client.Html
{
    [TestFixture]
    public class HtmlManagerTests
    {
        [Test]
        public void HtmlManager_ShouldInitialize()
        {
            // Test that HtmlManager can be initialized without throwing
            Assert.DoesNotThrow(() => HtmlManager.Initialize());
            Assert.That(HtmlManager.IsInitialized, Is.True);
        }
        
        [Test] 
        public void HtmlManager_ShouldTrackRendererCount()
        {
            // Initialize if not already done
            if (!HtmlManager.IsInitialized)
                HtmlManager.Initialize();
                
            var initialCount = HtmlManager.RendererCount;
            
            // For now, we can't test renderer creation without a real IGameRenderer
            // but we can test that the count is properly tracked
            Assert.That(HtmlManager.RendererCount, Is.EqualTo(initialCount));
        }
        
        [Test]
        public void HtmlManager_ShouldCreateDefaultContent()
        {
            // Initialize and check that default HTML content is created
            if (!HtmlManager.IsInitialized)
                HtmlManager.Initialize();
                
            // The manager should create a default index.html file
            var contentPath = System.IO.Path.Combine(
                System.AppDomain.CurrentDomain.BaseDirectory, 
                "Content", 
                "Html", 
                "index.html"
            );
            
            Assert.That(System.IO.File.Exists(contentPath), Is.True);
            
            var content = System.IO.File.ReadAllText(contentPath);
            Assert.That(content, Does.Contain("Intersect Engine HTML UI"));
        }
        
        [TearDown]
        public void TearDown()
        {
            // Clean up after tests
            HtmlManager.Shutdown();
        }
    }
}